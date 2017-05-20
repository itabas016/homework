#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <errno.h>
#include <unistd.h>
#include <fcntl.h>
#include <sys/types.h>
 
int main(int argc, char *argv[])
{
    char *buf = NULL;
    int fd_src = -1;
    int fd_dest = -1;
    int buf_size = 4096;
    int cnt = 0;
    struct flock lock;
 
    if (argc < 3) {
        printf("usage: %s <src_file> <dest_file> [buf_size]\n", argv[0]);
        return 0;
    }
 
    if ((fd_src=open(argv[1], O_RDONLY)) == -1) {
        perror("open src. file");
        return 1;
    }
    if ((fd_dest=open(argv[2], O_WRONLY|O_CREAT|O_EXCL, 0664)) == -1) {
        perror("open dest. file");
        close(fd_src);
        return 2;
    }
    if (argc == 4) {
        buf_size = atoi(argv[3]);
    }
    buf = sbrk(buf_size);
    if ((void*)-1 == buf) {
        perror("malloc");
        close(fd_src);
        close(fd_dest);
        return 3;
    }
 
    lock.l_type = F_RDLCK;
    lock.l_whence = SEEK_SET;
    lock.l_start = 0;
    lock.l_len = 0;
    lock.l_pid = -1;
    if (fcntl(fd_src, F_SETLK, &lock) == -1) {
        fprintf(stderr, "%s has been locked by other process\n", argv[1]);
        close(fd_src);
        close(fd_dest);
        return 8;
    }
 
    errno = 0;
    while ((cnt = read(fd_src, buf, buf_size)) > 0) {
        if (write(fd_dest, buf, cnt) < cnt) {
            perror("write");
            close(fd_src);
            close(fd_dest);
            return 4;
        }
    }
    if (0 != errno) {
        perror("read");
    }
    close(fd_src);
    fd_src = -1;
    close(fd_dest);
    fd_dest = -1;
    brk(buf);
 
    return 0;
}

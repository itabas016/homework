/*
//给定程序中函数fun的功能是：对形参s所指字符串中下标为奇数的字符按ASCII码大小递增排序，
并将排序后下标为奇数的字符取出，存入形参p所指字符数组中，形成一个新串。
例如，形参s所指字符串为baawrskjghzlicda，执行后p所指字符数组中的字符串应为aachjlsw。
*/

#include  <stdio.h>
void fun(char *s,char *p)
{ 
	int i,j,n,x,t;
	n=0;
	for(i=0; s[i]!='\0'; i++) n++;
	for(i=1; i<n-2; i=i+2)
	{
		t=i;
		for(j= i+2;j<n;j=j+2)
		if(s[t]>s[j]) t=j;
		if(t!=i)
		{ 
			x=s[i]; s[i]=s[t]; s[t]=x;
		}
	}
	for(i=1,j=0;i<n;i=i+2,j++)  p[j]=s[i];
	
	p[j]= '\0';
}

void question_1()
{ 
	char s[80]="baawrskjghzlicda",p[50];
	printf("\nThe original string is: %s\n",s);
	fun(s,p);
	printf("\nThe result is:  %s\n",p);
}

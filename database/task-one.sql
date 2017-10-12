# create statement:
# sqlite structure

CREATE TABLE `S` ( `SNO` TEXT, `SNAME` TEXT, `STATUS` INTEGER, `CITY` TEXT );
CREATE TABLE `P` ( `PNO` TEXT, `PNAME` TEXT, `COLOR` TEXT, `WELGHT` INTEGER );
CREATE TABLE `J` ( `JNO` TEXT, `JNAME` TEXT, `CITY` TEXT );
CREATE TABLE `SPJ` ( `SNO` TEXT, `PNO` TEXT, `JNO` TEXT, `QTY` INTEGER );

# insert statement:

--S
insert into S (SNO, SNAME, STATUS, CITY) values ('S1', '精  益', 20, '天津');
insert into S (SNO, SNAME, STATUS, CITY) values ('S2', '盛  锡', 10, '北京');
insert into S (SNO, SNAME, STATUS, CITY) values ('S3', '东方红', 30, '北京');
insert into S (SNO, SNAME, STATUS, CITY) values ('S4', '丰泰盛', 20, '天津');
insert into S (SNO, SNAME, STATUS, CITY) values ('S5', '为  民', 30, '上海');

--P
insert into P (PNO, PNAME, COLOR, WELGHT) values ('P1', '螺母', '红', 12);
insert into P (PNO, PNAME, COLOR, WELGHT) values ('P2', '螺栓', '绿', 17);
insert into P (PNO, PNAME, COLOR, WELGHT) values ('P3', '螺丝刀', '蓝', 14);
insert into P (PNO, PNAME, COLOR, WELGHT) values ('P4', '螺丝刀', '红', 14);
insert into P (PNO, PNAME, COLOR, WELGHT) values ('P5', '凸轮', '蓝', 40);
insert into P (PNO, PNAME, COLOR, WELGHT) values ('P6', '螺母', '红', 30);

--J
insert into J (jno, jname, city) values ('J1', '三 建', '北京');
insert into J (jno, jname, city) values ('J2', '一 汽', '长春');
insert into J (jno, jname, city) values ('J3', '弹簧厂', '天津');
insert into J (jno, jname, city) values ('J4', '造船厂', '天津');
insert into J (jno, jname, city) values ('J5', '机车厂', '唐山');
insert into J (jno, jname, city) values ('J6', '无线电厂', '常州');
insert into J (jno, jname, city) values ('J7', '半导体厂', '南京');

--SPJ
insert into SPJ (SNO, PNO, JNO, QTY) values ('S1', 'P1', 'J1', 200);
insert into SPJ (SNO, PNO, JNO, QTY) values ('S1', 'P1', 'J3', 100);
insert into SPJ (SNO, PNO, JNO, QTY) values ('S1', 'P1', 'J4', 700);
insert into SPJ (SNO, PNO, JNO, QTY) values ('S1', 'P2', 'J2', 100);
insert into SPJ (SNO, PNO, JNO, QTY) values ('S2', 'P3', 'J1', 400);
insert into SPJ (SNO, PNO, JNO, QTY) values ('S2', 'P3', 'J2', 200);
insert into SPJ (SNO, PNO, JNO, QTY) values ('S2', 'P3', 'J4', 500);
insert into SPJ (SNO, PNO, JNO, QTY) values ('S2', 'P3', 'J5', 400);
insert into SPJ (SNO, PNO, JNO, QTY) values ('S2', 'P5', 'J1', 400);
insert into SPJ (SNO, PNO, JNO, QTY) values ('S2', 'P5', 'J2', 100);
insert into SPJ (SNO, PNO, JNO, QTY) values ('S3', 'P1', 'J1', 200);
insert into SPJ (SNO, PNO, JNO, QTY) values ('S3', 'P3', 'J1', 200);
insert into SPJ (SNO, PNO, JNO, QTY) values ('S4', 'P5', 'J1', 100);
insert into SPJ (SNO, PNO, JNO, QTY) values ('S4', 'P6', 'J3', 300);
insert into SPJ (SNO, PNO, JNO, QTY) values ('S4', 'P6', 'J4', 200);
insert into SPJ (SNO, PNO, JNO, QTY) values ('S5', 'P2', 'J4', 100);
insert into SPJ (SNO, PNO, JNO, QTY) values ('S5', 'P3', 'J1', 200);
insert into SPJ (SNO, PNO, JNO, QTY) values ('S5', 'P6', 'J2', 200);
insert into SPJ (SNO, PNO, JNO, QTY) values ('S5', 'P6', 'J4', 500);


# Question & answer

--(1) 找出所有供应商的姓名和所在城市。
	
	select SNAME, CITY from S;

--(2) 找出所有零件的名称、颜色、重量。

	select PNAME, COLOR, WELGHT from P;

--(3) 找出使用供应商S1所供应零件的工程号码。

	select JNO from SPJ where SNO = 'S1';

--(4) 找出工程项目J2使用的各种零件的名称及其数量。

	select P.PNAME, SPJ.QTY from SPJ 
	inner join P on P.PNO = SPJ.PNO 
	where SPJ.JNO = 'J2';

--(5) 找出上海厂商供应的所有零件号码。

	select distinct SPJ.PNO from SPJ
	inner join S on S.SNO = SPJ.SNO
	where S.CITY='上海';

--(6) 找出使用上海产的零件的工程名称。

	select J.JNAME from SPJ
	inner join S on S.SNO = SPJ.SNO
	inner join J on J.JNO = SPJ.JNO
	where S.CITY='上海';

--(7) 找出没有使用天津产的零件的工程号码。

	select distinct J.JNO from SPJ
	inner join S on S.SNO = SPJ.SNO
	inner join J on J.JNO = SPJ.JNO
	where S.CITY!='天津';

--(8) 把全部红色零件的颜色改成蓝色。
	
	update P set COLOR = '蓝' where COLOR = '红';
	commit;
	select * from P;

--(9) 由S5供给J4的零件P6改为由S3供应，请作必要的修改。

	update SPJ set SNO = 'S3' where SNO = 'S5' and JNO = 'J4' and PNO = 'P6';
	commit;

--(10) 从供应商关系中删除S2的记录，并从供应情况关系中删除相应的记录。

	select * from SPJ where SNO = 'S2';
	delete from SPJ where SNO = 'S2'
	select * from SPJ where SNO = 'S2';
	delete from S where SNO = 'S2';

--(11) 请将（S2，J6，P4，200）插入供应情况关系。
	
	insert into SPJ (SNO, PNO, JNO, QTY) values ('S2', 'P4', 'J6', 200);
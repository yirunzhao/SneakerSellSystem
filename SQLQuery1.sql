select * from shoe
delete from shoe 
insert shoe values('Air Jordan 1 С����',3000,'����Ь','ShoesImage\xiaoshandian.jpg');
insert shoe values('Air Jordan 1 ֩����',3500,'����Ь','ShoesImage\zhizhuxia.jpg');
insert shoe values('Air Jordan 1 ��������',1900,'����Ь','ShoesImage\tiyuhuabao.jpg');
insert shoe values('Air Jordan 1 �ð˸�',1600,'����Ь','ShoesImage\tubage.jpg');
insert shoe values('Air Jordan 1 Turbo Green',2200,'����Ь','ShoesImage\turbo.jpg');
insert shoe values('Yeezy 350 �����޶�',2800,'�˶�Ь','ShoesImage\yazhou.jpg');
insert shoe values('Yeezy 350 �װ���',2800,'�˶�Ь','ShoesImage\baibanma.jpg');
insert shoe values('Ultra Boost ����',900,'��Ь','ShoesImage\ubwhite.jpg');
insert shoe values('Ultra Boost Ȩ�� ���',1200,'��Ь','ShoesImage\ubblue.jpg');
insert shoe values('Air Jordan 6 �ں� OG',1800,'����Ь','ShoesImage\bred.jpg');

insert shoe values('D.VA ��ǹ�����Ҽ�ģ��',139,'����','ShoesImage\dva.png',100);
insert shoe values('Դ�� ն ����ñ �����ȷ�',159,'ñ��','ShoesImage\genji.png',66);

update card set balance = (select cast(ceiling(rand() * 10000) as int)) where cid=7
update card set balance = 123456 where cid = 1
select * from card
delete from card where cid = 9
select * from shoe
select * from member
select * from Member inner join Card on member.cid = card.cid
delete from card where cid = 5
select * from BuyInfo
update buyinfo set status = 0
select * from BuyInfo where MID = 20170002
delete from BuyInfo where cid = 1
insert into BuyInfo values(20170002,1,'˳��','Air Jordan 1 С����')
delete from buyinfo
delete from buyinfo where cid = 2 and sname = 'Air Jordan 1 С����'
select * from member
select * from card
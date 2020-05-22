select * from shoe
delete from shoe 
insert shoe values('Air Jordan 1 –°…¡µÁ',3000,'¿∫«Ú–¨','ShoesImage\xiaoshandian.jpg');
insert shoe values('Air Jordan 1 ÷©÷Îœ¿',3500,'¿∫«Ú–¨','ShoesImage\zhizhuxia.jpg');
insert shoe values('Air Jordan 1 ÃÂ”˝ª≠±®',1900,'¿∫«Ú–¨','ShoesImage\tiyuhuabao.jpg');
insert shoe values('Air Jordan 1 Õ√∞À∏Á',1600,'¿∫«Ú–¨','ShoesImage\tubage.jpg');
insert shoe values('Air Jordan 1 Turbo Green',2200,'¿∫«Ú–¨','ShoesImage\turbo.jpg');
insert shoe values('Yeezy 350 —«÷ﬁœﬁ∂®',2800,'‘À∂Ø–¨','ShoesImage\yazhou.jpg');
insert shoe values('Yeezy 350 ∞◊∞ﬂ¬Ì',2800,'‘À∂Ø–¨','ShoesImage\baibanma.jpg');
insert shoe values('Ultra Boost ¥ø∞◊',900,'≈‹–¨','ShoesImage\ubwhite.jpg');
insert shoe values('Ultra Boost »®”Œ “ÏπÌ',1200,'≈‹–¨','ShoesImage\ubblue.jpg');
insert shoe values('Air Jordan 6 ∫⁄∫Ï OG',1800,'¿∫«Ú–¨','ShoesImage\bred.jpg');

insert shoe values('D.VA π‚«πŒ‰∆˜π“º˛ƒ£–Õ',139,'π“ Œ','ShoesImage\dva.png',100);
insert shoe values('‘¥ œ ’∂ ∞Ù«Ú√±  ÿÕ˚œ»∑Ê',159,'√±◊”','ShoesImage\genji.png',66);

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
insert into BuyInfo values(20170002,1,'À≥∑·','Air Jordan 1 –°…¡µÁ')
delete from buyinfo
delete from buyinfo where cid = 2 and sname = 'Air Jordan 1 –°…¡µÁ'
select * from member
select * from card
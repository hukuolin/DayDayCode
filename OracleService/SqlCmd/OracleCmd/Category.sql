-- Create table
create table Category
(
  Id         char(36) not null  ,
  Name       varchar2(64) not null,
  key        varchar(64) not null,
  DataDesc   varchar2(255),
  ItemSort       number(8),
  createby   varchar2(64),
  createtime date not null,
  updatetime date not null
);
alter table Category
  add constraint PKId primary key (ID);

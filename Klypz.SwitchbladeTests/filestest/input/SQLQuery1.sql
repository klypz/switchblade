select c.* 
from m4u.CreditoPrePago c join m4u.PessoaPOS pp on c.PessoaPosGUID = pp.PessoaPosGUID 
where CreditoPrePagoGUID = '4cf4ea77-d421-879f-5644-88d1d613c5f6' order by c.DataTransacao desc

SELECT * FROM M4U.Etapa

select c.* 
--update c set c.EtapaID = 2
from m4u.CreditoPrePago c join m4u.PessoaPOS pp on c.PessoaPosGUID = pp.PessoaPosGUID 
where c.EtapaID = 1 and CreditoPrePagoGUID = '4cf4ea77-d421-879f-5644-88d1d613c5f6' order by c.DataTransacao desc
USE AB_INFOBANC
GO

CREATE OR ALTER PROCEDURE BAAS_INFOBANK_ENDERECOS (@CodigoCliente VARCHAR(15)) AS

BEGIN

	SELECT		CODENDERECO AS Codigo,
				TipoEndereco,
				Endereco,
				Numero,
				Complemento,
				Bairro,
				Cidade,
				Uf
				Cep,
				DDD + Telefone AS Telefone,
				DDD_CELULAR + Celular AS Celular,			
				Correspondencia,
				CodPais AS CodigoPais			
	FROM		ENDERECOS E INNER JOIN CLIENTES C 
					ON E.CGC_CPF = C.CGC_CPF 
					AND E.SEQUENCIA = C.SEQUENCIA
	WHERE		C.CODCLIENTE = @CodigoCliente


END
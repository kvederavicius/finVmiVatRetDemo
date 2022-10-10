# finVmiVatRetDemo
<b>Finvalda - VMI - Vat Return - TEST web service issues</b>

> Programa su "production" web service'o adresu `https://taxfree-ws.vmi.lt:8843/VATRefundforForeignTravelerTR` grąžina tokius rezultatus:

```
20001 - Šio paslaugos gavėjo šio metodo kreipinys su tokiu RequestId jau yra
20005 - Nerasta deklaracija su nurodytu DocID numeriu
20003 - Siuntėjo identifikacinis numeris (kodas) nerastas.
```


> Tačiau su "testiniu" adresu `https://taxfree-tst-ws.vmi.lt:8844/VATRefundforForeignTravelerTR`, išmetama `WebException` ir tekstas:

```
Unable to connect to the remote server
No connection could be made because the target machine actively refused it 195.182.64.196:8844
```

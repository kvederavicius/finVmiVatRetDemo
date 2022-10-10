# finVmiVatRetDemo
<b>Finvalda - VMI - Vat Return - TEST web service issues</b>

Programa su "production" web service'o adresu <code>https://taxfree-ws.vmi.lt:8843/VATRefundforForeignTravelerTR</code> grąžina tokius rezultatus:

<code>
20001 - Šio paslaugos gavėjo šio metodo kreipinys su tokiu RequestId jau yra</br>
20005 - Nerasta deklaracija su nurodytu DocID numeriu</br>
20003 - Siuntėjo identifikacinis numeris (kodas) nerastas.
 </code>

<br>
Tačiau su "testiniu" adresu <code></code>, išmetama <code>WebException</code> ir tekstas:

<code>
Unable to connect to the remote server</br>
No connection could be made because the target machine actively refused it 195.182.64.196:8844
</code>

import { TableBody, TableContainer, TableRow, Paper, Table,TableCell } from "@mui/material";
import { useStoreContext } from "../../app/content/StoreContext";
import { currencyFormat } from "../../app/util/util";

export default function BasketSummary(){
    const {basket} = useStoreContext();
    const subtotal = basket?.items.reduce((sum, item) => sum + (item.quantity * item.price),0) ?? 0;
    const deliveryFee = subtotal> 1000 ? 0 : 500;

    return (
        <>
            <TableContainer component={Paper} variant={'outlined'}>
                <Table>
                    <TableBody>
                        <TableRow>
                            <TableCell colSpan={2}>Subtotal</TableCell>
                            <TableCell align="right">{currencyFormat(subtotal)}</TableCell>
                        </TableRow>
                        <TableRow>
                            <TableCell colSpan={2}>Delivery fee</TableCell>
                            <TableCell align="right">{currencyFormat(deliveryFee)}</TableCell>
                        </TableRow>
                        <TableRow>
                            <TableCell colSpan={2}>Total</TableCell>
                            <TableCell align="right">{currencyFormat(subtotal + deliveryFee)}</TableCell>
                        </TableRow>
                        <TableRow>
                            <span style={{fontStyle: 'italic'}}>Order over Rp 1.000.000 for free delivery</span>
                        </TableRow>
                    </TableBody>
                </Table>
            </TableContainer>
        </>

    )
}
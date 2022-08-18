import { GridItem } from "@chakra-ui/react";

// interface Account {
//     AccountNumber:string;
//     AccountType:string;
//     CustomerID:string;
//     Balance:string;
// }



const Accounts = ({data}) =>{

    return(
        <ul>
            {data.map(account =>(
                <li key={account.accountNumber}>
                    {account.balance}
                </li>
            ))}
        </ul>
    );
};

export default Accounts;
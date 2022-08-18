import { GridItem } from "@chakra-ui/react";

interface AccountProps{
    accounts:Account[];
    loading: boolean;
}

interface Account {
    AccountNumber:string;
    AccountType:string;
    CustomerID:string;
    Balance:string;
}



export function Accounts(props:AccountProps){

    if(props.loading){
        return <h2>Loading...</h2>
    }

    return(
        <GridItem>
            {props.accounts.map(account =>(
                <li key={account.Balance}>
                    {account.AccountType}
                </li>
            ))}
        </GridItem>
    );
};

export default Accounts;
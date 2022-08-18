import { Box, GridItem } from "@chakra-ui/react";

// interface Account {
//     AccountNumber:string;
//     AccountType:string;
//     CustomerID:string;
//     Balance:string;
// }



const Accounts = ({data, loading}) =>{

    if(loading){
        return <h2>Loading...</h2>
    }

    return(
        <GridItem>
            {data.map(account =>(
                    
                    <div key={account.accountNumber}>
                        <Box bg ='white' maxW='sm' borderWidth='1px' borderRadius='lg' overflow='hidden' mt='1' fontWeight='semibold'>
                            Account Number: {account.accountNumber}
                        <br/>
                        </Box>
                        <Box bg='lightblue' maxW='sm' borderWidth='1px' borderRadius='lg' overflow='hidden'>
                            Type: {account.accountType}
                        <br/>
                            Balance : {account.balance}
                        </Box>
                        
                    </div>
                     
            ))}
        </GridItem>
    );
};

export default Accounts;
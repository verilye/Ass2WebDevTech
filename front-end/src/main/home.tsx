import{
    Box,
    Text,
    FormControl,
    Modal,
    ModalOverlay,
    ModalContent,
    ModalHeader,
    Heading,
    Grid,
    GridItem,
    VStack,
    Flex,
    Divider,
    chakra,
    Button,
    Container

} from '@chakra-ui/react';
import React from 'react';
import { useState, useEffect } from 'react';
import { json } from 'stream/consumers';
import Accounts from '../components/Accounts';
// import Accounts from '../components/Accounts';
import { Navbar } from '../header/navbar';


export interface HomeProps {

    disabled:boolean;
    visible:boolean;
    onLogout(): void;

}

var name = sessionStorage.getItem("user");

interface Account {
    AccountNumber:string;
    AccountType:string;
    CustomerID:string;
    Balance:string;
}

export function Home(props: HomeProps){

    const [accounts,setAccounts] = useState<string[]>([]);
    const [loading, setLoading] = useState(false); 
    const [currentPage, setCurrentPage] = useState(1);
    const [accountsPerPage, setAccountsPetPage] = useState(10);

    useEffect(() =>{
        const fetchAccounts = ()=>{
            
            setLoading(true);


            fetch('http://localhost:5213/api/Home', {
                method:'POST',
                headers: { "content-type": "application/json" },
                body: JSON.stringify({
                    id : sessionStorage.getItem("user")
                })
                }).then (response => response.json())
                .then (body => {
                    
                    console.log(body);
                    setAccounts(body);
                });

            
           
            setLoading(false);
        }  
        fetchAccounts();  
            
    });

    return(

        //Paginate account data
        // include   mt={10} in pagination so that accounts are separated properly

        <div className='Home-Page'>

            <div>
                <Box as={Container} maxW="7xl" mt={5} pt={100} pb={500} fontWeight='semibold' fontSize={20}>
                    ACCOUNTS
                    <Divider mt={12} mb={12} />
                    <Grid
                        templateColumns={{
                        base: 'repeat(1, 1fr)',
                        sm: 'repeat(2, 1fr)',
                        md: 'repeat(2, 1fr)',
                        }}
                        gap={4}
                        >
                       <Accounts
                            data ={accounts}
                            loading ={loading}
                       />
                    </Grid>
                </Box>
            </div>

        </div>
        

    )


}

export default Home;
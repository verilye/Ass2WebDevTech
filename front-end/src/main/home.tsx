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
import { useState } from 'react';
import { Navbar } from '../header/navbar';


export interface HomeProps {

}

export function Home(props: HomeProps){
    return(

        
        //Paginate account data
        // include   mt={10} in pagination so that accounts are separated properly


        <div className='Home-Page'>
            <div>
                <Box as={Container} maxW="7xl" mt={5} pt={100} pb={500}>
                    Accounts
                    <Divider mt={12} mb={12} />
                    <Grid
                        templateColumns={{
                        base: 'repeat(1, 1fr)',
                        sm: 'repeat(2, 1fr)',
                        md: 'repeat(2, 1fr)',
                        }}
                        gap={4}
                        >
                        <GridItem colSpan={1}>
                            Account 1
                        </GridItem>
                        <GridItem>
                           Account 2
                        </GridItem>
                        <GridItem
                          mt={10}
                        >
                           Account 3
                        </GridItem>
                    </Grid>
                </Box>
            </div>

        </div>
        

    )


}

export default Home;
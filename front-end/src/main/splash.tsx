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
import SplashNav from '../header/navbar';


export interface LoginDetails{

}

export interface SplashProps {

    onLogin(props: LoginDetails): void;

}

export function Splash(props: SplashProps){
    return(

        <div className='Splash-Page'>
            <div>
                <Box as={Container} maxW="7xl" mt={14} p={200} pt={300}>
                    <Grid
                        templateColumns={{
                        base: 'repeat(1, 1fr)',
                        sm: 'repeat(2, 1fr)',
                        md: 'repeat(2, 1fr)',
                        }}
                        gap={4}>
                        <GridItem colSpan={1}>
                        <VStack alignItems="flex-start" spacing="20px">
                            <chakra.h1 fontSize="4xl" fontWeight="700">
                                MCBA Bank
                            </chakra.h1>
                            <Button colorScheme="blue" size="md"  onClick={props.onLogin}>
                                Login
                            </Button>
                        </VStack>
                        </GridItem>
                        <GridItem>
                            <Text fontSize='3xl'>
                                Simple
                                <br/>
                                Easy
                                <br/>
                                Fake
                            </Text>
                        </GridItem>
                    </Grid>
                    <Divider mt={12} mb={12} />
                </Box>
            </div>

        </div>
        

    )


}

export default Splash;
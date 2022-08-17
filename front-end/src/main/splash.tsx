import{
    useDisclosure,
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
    Container,
    Stack,
    Input

} from '@chakra-ui/react';
import React from 'react';
import { useState } from 'react';
import SplashNav from '../header/navbar';


export interface LoginDetails{
    username:string;
    password:string;

}

export interface SplashProps {

    onLogin(props: LoginDetails): void;

}


export function Splash(props: SplashProps){

    const [username, setUser] = useState('');
    const [password, setPassword] = useState('');

    const usernameOnChange = (event) => {
        setUser(event.target.value);
      };
    const passwordOnChange = (event) => {
    setPassword(event.target.value);
    };


    const onLogin = () =>{

        const loginDetails: LoginDetails ={
            username:username,
            password: password,
        };
    
        props.onLogin(loginDetails);
        setUser('');
        setPassword('');
    
    }



    return(

        <div className='Splash-Page'>
            <div>
                <Box backgroundColor={"white"} as={Container} maxW="7xl" mt={14} p={200} pt={300}>
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
                            <FormControl>
                                <Input
                                    name = "username"
                                    placeholder="User name"
                                    onChange ={usernameOnChange}
                                    type="username"
                                    id="username"
                                />
                                <Input
                                    name = "password"
                                    placeholder="Password"
                                    onChange ={passwordOnChange}
                                    type="password"
                                    id="password"
                                />
                                 <Button colorScheme="blue" size="md"  onClick ={onLogin} id="login">
                                    Login
                                </Button>
                            </FormControl>
                        </VStack>
                        </GridItem>
                        <GridItem>
                            <Text fontSize='3xl'>
                                At MCBA Bank, we're here to make a difference
                                <br/>
                                We're here to store money
                                <br/>
                                Start an account today
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
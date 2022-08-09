import{
    FormControl,
    Modal,
    ModalOverlay,
    ModalContent,
    ModalHeader,
    Heading

} from '@chakra-ui/react';
import React from 'react';
import { useState } from 'react';


export interface LoginDetails{
    username:string,
    password:string
}

export interface LoginProps {

    // onLogin(props: LoginDetails): void;
    enabled: boolean;
    visible: boolean;

}

export function Login(props: LoginProps){
    const [formValidationMessage, setFormValidationMessage] = useState('');
    const [formValidationVisibility, setFormValidationVisibility] = useState(true);
    const [username, setUsername] = useState('');
    const [password, setPassword] = useState('');




    return(
        <FormControl>
            <Heading>Boom Baby</Heading>
        </FormControl>
    )


}

export default Login;
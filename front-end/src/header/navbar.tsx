import{
    Menu,
    MenuButton,
    MenuList,
    MenuDivider,
    MenuItem,
    Box,
    Avatar,
    Center,
    Flex,
    Text,
    IconButton,
    Button,
    Stack,
    Collapse,
    Icon,
    Link,
    Popover,
    PopoverTrigger,
    PopoverContent,
    useColorModeValue,
    useBreakpointValue,
    useDisclosure,
    
} from '@chakra-ui/react';
import {
    HamburgerIcon,
    CloseIcon,
    ChevronDownIcon,
    ChevronRightIcon,
    MoonIcon,
  } from '@chakra-ui/icons';

import React from 'react';
import { useState } from 'react';


export interface NavProps {
    toggleDeposit():void;
    toggleDepositClose():void;
    toggleWithdraw():void;
    toggleTransfer():void;
    toggleStatements():void;
    toggleProfile():void;
    logout():void;
}

export function Navbar(props: NavProps){
    return(

        <Box bg={useColorModeValue('blue.100', 'blue.900')} px={4}>
            <Flex h={16} alignItems={'center'} justifyContent={'space-between'}>
                
                <Box style={{fontWeight: 'bold', fontSize:'40px'}}>MCBA Bank</Box>

                <Stack direction={'row'} spacing={5}>
                    <Button colorScheme="blue" onClick={props.toggleDeposit}>Deposit</Button>
                    <Button  onClick ={props.toggleWithdraw}>Withdraw</Button>
                    <Button colorScheme="blue" onClick ={props.toggleTransfer}>Transfer</Button>
                    <Button onClick ={props.toggleStatements}>My Statements</Button>
                </Stack>

                <Flex alignItems={'center'}>
                    <Stack direction={'row'} spacing={7}>
                        <Button colorScheme="red" onClick ={props.toggleProfile}>My Profile</Button>
                        <Button colorScheme="green"onClick ={props.logout}>Logout</Button>
                    </Stack>
                </Flex>
            </Flex>
        </Box>
    )


}

export default Navbar;
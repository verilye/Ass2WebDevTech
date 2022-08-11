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

}

export function Navbar(props: NavProps){
    return(

        <Box bg={useColorModeValue('blue.100', 'blue.900')} px={4}>
            <Flex h={16} alignItems={'center'} justifyContent={'space-between'}>
                <Box>MCBA</Box>
                <Flex alignItems={'center'}>
                <Stack direction={'row'} spacing={7}>
                    <Box>
                        Login
                    </Box>
                </Stack>
                </Flex>
            </Flex>
        </Box>
    )


}

export default Navbar;
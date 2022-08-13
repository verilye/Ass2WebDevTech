import { Modal, ModalOverlay, ModalContent, ModalHeader, ModalFooter, ModalBody, ModalCloseButton, Select, Input, Button, Alert, AlertIcon, AlertDescription } from "@chakra-ui/react";
import { Flex, Spacer } from "@chakra-ui/layout";
import { useState } from "react";

export interface DepositDetails {
    accountNumber:string,
    //etc
}

export interface DepositProps {
    onClose(): void;
    visible: boolean;
    disabled: boolean;
}

//register component
export function Deposit(props: DepositProps) {
    
    //store variables here
    const [accountNumber, setAccountNumber] = useState('');

    const accountNumberOnChange = (event) => setAccountNumber(event.target.value);

    const onDeposit = () => {
        // Validate data here
    };

    return (
        <Modal isOpen={props.visible} onClose={props.onClose} id="register">
            <ModalOverlay />
            <ModalContent>
                <ModalHeader>Profile</ModalHeader>
                <ModalCloseButton />
                <ModalBody>
                    {/* This is how text input is formatted <Input disabled={props.disabled} onChange={usernameOnChange} placeholder="username" variant="filled" mb={3} type="username" id="username" /> */}
                    <Select disabled={props.disabled} onChange={accountNumberOnChange} mb={3} variant="filled" id="state">
                        {/* Paginate account options like so <option value="account1">Account1</option> */}
                    </Select>
                </ModalBody>

                <ModalFooter>
                    <Flex width="100%">
                        <Button disabled={props.disabled} onClick={props.onClose} id="cancel">
                            Cancel
                        </Button>
                        <Spacer></Spacer>
                        <Button disabled={props.disabled} onClick={onDeposit} id="deposit">
                            Register
                        </Button>
                    </Flex>
                </ModalFooter>
            </ModalContent>
        </Modal>
    );
}

export default Deposit;
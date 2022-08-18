import { Modal, ModalOverlay, ModalContent, ModalHeader, ModalFooter, ModalBody, ModalCloseButton, Select, Input, Button, Alert, AlertIcon, AlertDescription } from "@chakra-ui/react";
import { Flex, Spacer } from "@chakra-ui/layout";
import { useEffect, useState } from "react";
import { isVisible } from "@testing-library/user-event/dist/utils";


interface Account {
    accountNumber:string;
    accountType:string;
    customerID:string;
    balance:string;
}


export interface DepositDetails {
    accountNumber:string,
    //etc
}

export interface DepositProps {
    disabled: boolean;
    onClose(): void;
    visible: boolean;
    
}

//register component
export function Deposit(props: DepositProps) {

    const [accounts,setAccounts] = useState<Account[]>([]);
    const [loading, setLoading] = useState(false); 
    const [currentPage, setCurrentPage] = useState(1);
    const [accountsPerPage, setAccountsPetPage] = useState(10);
    
    //store variables here
    const [comment, setComment]= useState('');
    const [accountNumber, setAccountNumber] = useState('');
    const [amount, setAmount] = useState('');

    const commentOnChange = (event) =>setComment(event.target.value);
    const accountNumberOnChange = (event) => setAccountNumber(event.target.value);
    const amountOnChange = (event) => setAmount(event.target.value);

    const onDeposit = () => {
        
        fetch('http://localhost:5213/api/Deposit', {
            method:'POST',
            headers: { "content-type": "application/json" },
            body: JSON.stringify(
                    {id : accountNumber,
                     amount : amount})
                })
        props.onClose();      
        return;

    };

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
            
    },[]);

    return (
        <Modal isOpen={props.visible} onClose={props.onClose} id="deposit">
            <ModalOverlay />
            <ModalContent>
                <ModalHeader>Deposit</ModalHeader>
                <ModalBody>How much would you like to deposit?</ModalBody>
                <ModalCloseButton />
                <ModalBody>
                    <Input
                        disabled={props.disabled}
                        onChange={amountOnChange}
                        placeholder="$"
                        type="amount"
                        id="amount"
                    />
                </ModalBody>
                <ModalBody></ModalBody>
                <ModalBody>
                    <Select disabled={props.disabled} onChange={accountNumberOnChange} mb={3} variant="filled" id="state">
                    {accounts.map(account =>(
                        <option value={account.accountNumber}> 
                            <div key={account.accountNumber}>
                                Account # {account.accountNumber}  Type: {account.accountType} Balance: {account.balance}
                            </div>
                        </option>
                     ))}   
                    </Select>
                </ModalBody>
                <ModalBody>Comment:</ModalBody>
                <ModalBody>
                    <Input
                        disabled={props.disabled}
                        onChange={commentOnChange}
                        placeholder="..."
                        type="comment"
                        id="comment"
                    />
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
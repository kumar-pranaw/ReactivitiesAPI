import React from 'react'
import { Menu, Container, Button } from 'semantic-ui-react'

interface IProps {
    openCreateForm: () => void;
}

const NavBar: React.FC<IProps> = ({openCreateForm}) => {
    return (
        <Menu fixed='top' inverted>
            <Container>
                <Menu.Item header>
                    <img alt="logo" src="/assets/logo.png" style= {{marginRight: '10px' }} />
                    Reactivities
                </Menu.Item>
                <Menu.Item  name='Activities' />
                <Menu.Item >
                    <Button onClick= {openCreateForm} positive content="Create Activity" />
                </Menu.Item>
            </Container>
        </Menu>
       
    )
}

export default NavBar
import React from 'react';
import CloseIcon from '@mui/icons-material/Close';
import { IconButton, List } from '@mui/material';

const Modal = ({children, visible, setVisible}) => {
    const classes = ['modal'];

    if(visible){
        classes.push('active');
    }

    return (
        <div className={classes.join(' ')}>
            <div className="modelContent">
                <List className="d-flex w-100 justify-content-end">
                    <IconButton onClick={() => setVisible(false)}>
                        <CloseIcon />
                    </IconButton>
                </List>
                {children}
            </div>
        </div>
    );
};

export default Modal;
import React, { useState } from 'react';
import { styled } from '@mui/material/styles';
import Box from '@mui/material/Box';
import List from '@mui/material/List';
import ListItem from '@mui/material/ListItem';
import ListItemAvatar from '@mui/material/ListItemAvatar';
import ListItemIcon from '@mui/material/ListItemIcon';
import ListItemText from '@mui/material/ListItemText';
import Avatar from '@mui/material/Avatar';
import IconButton from '@mui/material/IconButton';
import FormGroup from '@mui/material/FormGroup';
import FormControlLabel from '@mui/material/FormControlLabel';
import Checkbox from '@mui/material/Checkbox';
import Grid from '@mui/material/Grid';
import Typography from '@mui/material/Typography';
import FolderIcon from '@mui/icons-material/Folder';
import DeleteIcon from '@mui/icons-material/Delete';
import ArticleIcon from '@mui/icons-material/Article';
import EditIcon from '@mui/icons-material/Edit';

const Demo = styled('div')(({ theme }) => ({
  backgroundColor: theme.palette.background.paper,
}));

const ListPosts = (props) => {
  const [dense, setDense] = useState(false);
  const [secondary, setSecondary] = useState(true);

    return (
    <Box sx={{ flexGrow: 1 }}>  
      <Grid container spacing={2}>
        <Grid item xs={12}>
          <Demo>
            <List dense={dense}>
              {props.posts.map(
                (element) => (
                <ListItem
                  secondaryAction={
                    <ListItem>
                      <IconButton onClick={() => props.editPost(element.id)}edge="end" aria-label="edit">
                        <EditIcon />
                      </IconButton>
                      <IconButton onClick={() => props.removePost(element.id)} edge="end" aria-label="delete">
                        <DeleteIcon />
                      </IconButton>
                    </ListItem>
                  }
                >
                  <ListItemAvatar>
                    <Avatar>
                      <ArticleIcon />
                    </Avatar>
                  </ListItemAvatar>
                  <ListItemText
                    primary= {element.title}
                    secondary={secondary ? element.date : null}
                  />
                </ListItem>
              ))}
            </List>
          </Demo>
        </Grid>
      </Grid>
    </Box>
    );
};

export default ListPosts;
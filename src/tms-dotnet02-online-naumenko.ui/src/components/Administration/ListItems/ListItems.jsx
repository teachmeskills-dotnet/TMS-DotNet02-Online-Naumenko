import React from 'react';
import ListItemButton from '@mui/material/ListItemButton';
import ListItemIcon from '@mui/material/ListItemIcon';
import ListItemText from '@mui/material/ListItemText';
import DashboardIcon from '@mui/icons-material/Dashboard';
import PeopleIcon from '@mui/icons-material/People';
import FormatListNumberedIcon from '@mui/icons-material/FormatListNumbered';
import WebIcon from '@mui/icons-material/Web';
import TagIcon from '@mui/icons-material/Tag';
import Divider from '@mui/material/Divider';
import PhotoSizeSelectActualIcon from '@mui/icons-material/PhotoSizeSelectActual';
import SettingsIcon from '@mui/icons-material/Settings';
import LogoutIcon from '@mui/icons-material/Logout';
import List from '@mui/material/List';

const ListItems = (props) => {
  return (
    <List component="nav">
      <ListItemButton>
        <ListItemIcon>
          <PhotoSizeSelectActualIcon />
        </ListItemIcon>
        <ListItemText primary="Files" />
      </ListItemButton>
      <ListItemButton>
        <ListItemIcon>
          <FormatListNumberedIcon />
        </ListItemIcon>
        <ListItemText primary="Posts" />
      </ListItemButton>
      <ListItemButton>
        <ListItemIcon>
          <WebIcon />
        </ListItemIcon>
        <ListItemText primary="Pages" />
      </ListItemButton>
      <ListItemButton>
        <ListItemIcon>
          <PeopleIcon />
        </ListItemIcon>
        <ListItemText primary="Users" />
      </ListItemButton>
      <ListItemButton>
        <ListItemIcon>
          <TagIcon />
        </ListItemIcon>
        <ListItemText primary="Terms" />
      </ListItemButton>
      <ListItemButton>
        <ListItemIcon>
          <SettingsIcon />
        </ListItemIcon>
        <ListItemText primary="Options" />
      </ListItemButton>
      <Divider sx={{ my: 1 }} />
      <ListItemButton onClick={props.handleLogout}>
        <ListItemIcon>
          <LogoutIcon />
        </ListItemIcon>
        <ListItemText primary="Logout" />
      </ListItemButton>
    </List>
  );
}

export default ListItems;
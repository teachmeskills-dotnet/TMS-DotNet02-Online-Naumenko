import React, {useState} from 'react';
import { styled, createTheme, ThemeProvider } from '@mui/material/styles';
import CssBaseline from '@mui/material/CssBaseline';
import MuiDrawer from '@mui/material/Drawer';
import Box from '@mui/material/Box';
import MuiAppBar from '@mui/material/AppBar';
import Toolbar from '@mui/material/Toolbar';
import Typography from '@mui/material/Typography';
import Divider from '@mui/material/Divider';
import IconButton from '@mui/material/IconButton';
import Badge from '@mui/material/Badge';
import Container from '@mui/material/Container';
import Grid from '@mui/material/Grid';
import Link from '@mui/material/Link';
import List from '@mui/material/List';
import ListItem from '@mui/material/ListItem';
import MenuIcon from '@mui/icons-material/Menu';
import ChevronLeftIcon from '@mui/icons-material/ChevronLeft';
import NotificationsIcon from '@mui/icons-material/Notifications';
import ListItems  from '../ListItems/ListItems';
import ListPosts from './ListPosts/ListPosts';
import PostsData from '../../Sections/MainSection/PostsData';
import AddCircleOutlineIcon from '@mui/icons-material/AddCircleOutline';
import Modal from '../Modal/Modal';
import { Button, FormControl, InputLabel, NativeSelect, TextareaAutosize, TextField } from '@mui/material';

function Copyright(props) {
  return (
    <Typography variant="body2" color="text.secondary" align="center" {...props}>
      {'Copyright © '}
      <Link color="inherit" href="/">
        News Portal
      </Link>{' '}
      {new Date().getFullYear()}
      {'.'}
    </Typography>
  );
}

const drawerWidth = 240;

const AppBar = styled(MuiAppBar, {
  shouldForwardProp: (prop) => prop !== 'open',
})(({ theme, open }) => ({
  zIndex: theme.zIndex.drawer + 1,
  transition: theme.transitions.create(['width', 'margin'], {
    easing: theme.transitions.easing.sharp,
    duration: theme.transitions.duration.leavingScreen,
  }),
  ...(open && {
    marginLeft: drawerWidth,
    width: `calc(100% - ${drawerWidth}px)`,
    transition: theme.transitions.create(['width', 'margin'], {
      easing: theme.transitions.easing.sharp,
      duration: theme.transitions.duration.enteringScreen,
    }),
  }),
}));

const Drawer = styled(MuiDrawer, { shouldForwardProp: (prop) => prop !== 'open' })(
    ({ theme, open }) => ({
      '& .MuiDrawer-paper': {
        position: 'relative',
        whiteSpace: 'nowrap',
        width: drawerWidth,
        transition: theme.transitions.create('width', {
          easing: theme.transitions.easing.sharp,
          duration: theme.transitions.duration.enteringScreen,
        }),
        boxSizing: 'border-box',
        ...(!open && {
          overflowX: 'hidden',
          transition: theme.transitions.create('width', {
            easing: theme.transitions.easing.sharp,
            duration: theme.transitions.duration.leavingScreen,
          }),
          width: theme.spacing(7),
          [theme.breakpoints.up('sm')]: {
            width: theme.spacing(9),
          },
        }),
      },
    }),
  );

  const mdTheme = createTheme();
  
const Posts = () => {

  const [redirect, setRedirect] = useState(false);
  const [modalVisible, setModalVisible] = useState(false);
  const [id, setId] = useState('');
  const [open, setOpen] = useState(true);
  const toggleDrawer = () => {
    setOpen(!open);
  };
  const [posts, setPosts] = useState([]);
  const [post, setPost] = useState({});
  const handleLogout = async (event) => {
    event.preventDefault();

    await fetch('https://localhost:5001/users/logout',{
        method: 'POST',
        headers: {'Content-type': 'application/json'},
        credentials: 'include'
    })

    setRedirect(true);
  };

  if(redirect){
    return <Navigate to="/login"/>;
  }

  const getPosts = (posts) => {
    setPosts(posts);
  }
  const removePost = (id) => {
    setId(id);
    refreshPage();
  }
  const [postTitle, setPostTitle] = useState('');
  const [postType, setPostType] = useState('');
  const [postExcerpt, setPostExcerpt] = useState('');
  const [postContent, setPostContent] = useState('');
  const [postReadingTime, setPostReadingTime] = useState('');
  const [postFileId, setPostFileId] = useState('');
  const [postSlug, setPostSlug] = useState('');

  const addPost = () => {
    const test = {
      postTitle,
      postSlug,
      postType,
      postExcerpt,
      postContent,
      postReadingTime,
      postFileId
    };
    setPost(test);
    refreshPage();
  }
  
  function refreshPage() {
    window.location.reload(false);
  }
    return (
      <ThemeProvider theme={mdTheme}>
        <Modal visible={modalVisible} setVisible={setModalVisible}>
          <Typography
                component="h1"
                variant="h6"
                color="inherit"
                noWrap
                sx={{ flexGrow: 1 }}
              >
              Add Post
          </Typography>
          <TextField
            required
            id="title"
            name="title"
            label="Title"
            fullWidth
            autoComplete="family-name"
            variant="standard"
            onChange={e => setPostTitle(e.target.value)}
            value={postTitle}
          />
          <TextField className='mt-3'
            required
            id="slug"
            name="slug"
            label="Slug"
            fullWidth
            autoComplete="family-name"
            variant="standard"
            onChange={ e => setPostSlug(postTitle.replace(/ /g, '-').toLowerCase())}
            value={postSlug}
          />
          <FormControl fullWidth sx={{
                  marginTop: '10px'
                }}>
            <InputLabel variant="standard" htmlFor="uncontrolled-native">
              Type
            </InputLabel>
            <NativeSelect
              defaultValue={1}
              inputProps={{
                name: 'age',
                id: 'uncontrolled-native',
              }}
              onChange={e => setPostType(e.target.value)}
              value={postType}
            >
              <option value={2}>NotPublished</option>
              <option value={1}>Published</option>
              <option value={3}>Draft</option>
              <option value={3}>PendingApproval</option>
            </NativeSelect>
          </FormControl>
          <TextareaAutosize className='w-100 mt-2'
            minRows={3}
            placeholder="Excerpt"
            onChange={e => setPostExcerpt(e.target.value)}
            value={postExcerpt}
          />
          <TextareaAutosize className='w-100 mt-2'
            minRows={6}
            placeholder="Content"
            onChange={e => setPostContent(e.target.value)}
            value={postContent}
          />
          <TextField
            required
            id="readingTime"
            name="readingTime"
            label="Reading time"
            fullWidth
            autoComplete="family-name"
            variant="standard"
            onChange={e => setPostReadingTime(e.target.value)}
            value={postReadingTime}
          />
          <TextField
            required
            id="fileId"
            name="fileId"
            label="File id"
            fullWidth
            autoComplete="family-name"
            variant="standard"
            onChange={e => setPostFileId(e.target.value)}
            value={postFileId}
          />
          <Button onClick={addPost} className='mt-5 w-100' variant="contained">Add post</Button>
        </Modal>
        <PostsData posts={getPosts} removePost={id} addPost={post}/>
        <Box sx={{ display: 'flex' }}>
          <CssBaseline />
          <AppBar position="absolute" open={open}>
            <Toolbar
              sx={{
                pr: '24px', // keep right padding when drawer closed
              }}
            >
              <IconButton
                edge="start"
                color="inherit"
                aria-label="open drawer"
                onClick={toggleDrawer}
                sx={{
                  marginRight: '36px',
                  ...(open && { display: 'none' }),
                }}
              >
                <MenuIcon />
              </IconButton>
              <Typography
                component="h1"
                variant="h6"
                color="inherit"
                noWrap
                sx={{ flexGrow: 1 }}
              >
                Posts
              </Typography>
              <IconButton color="inherit">
                <Badge badgeContent={4} color="secondary">
                  <NotificationsIcon />
                </Badge>
              </IconButton>
            </Toolbar>
          </AppBar>
          <Drawer variant="permanent" open={open}>
            <Toolbar
              sx={{
                display: 'flex',
                alignItems: 'center',
                justifyContent: 'flex-end',
                px: [1],
              }}
            >
              <Typography variant="body2" color="text.secondary" align="left">
                <Link color="inherit" href='/'>
                  News Portal
                </Link>
              </Typography>
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <IconButton onClick={toggleDrawer}>
                <ChevronLeftIcon />
              </IconButton>
            </Toolbar>
            <Divider />
            <ListItems handleLogout={handleLogout}/>
          </Drawer>
          <Box
            component="main"
            sx={{
              backgroundColor: (theme) =>
                theme.palette.mode === 'light'
                  ? theme.palette.grey[100]
                  : theme.palette.grey[900],
              flexGrow: 1,
              height: '100vh',
              overflow: 'auto',
            }}
          >
            <Toolbar />
            <List sx={{
                  marginLeft: '15px'
                }}>
              <ListItem>
                <IconButton onClick={() => setModalVisible(true)} edge="end" aria-label="add">
                  <AddCircleOutlineIcon />
                </IconButton>
                &nbsp;&nbsp;Add post
              </ListItem>
            </List>
            <Container maxWidth="lg" sx={{ mt: 4, mb: 4 }}>
              <Grid container spacing={3}>
                {/* Posts */}
                <ListPosts posts={posts} removePost={removePost}/>
              </Grid>
              <Copyright sx={{ pt: 4 }} />
            </Container>
          </Box>
        </Box>
      </ThemeProvider>
    );
};

export default Posts;
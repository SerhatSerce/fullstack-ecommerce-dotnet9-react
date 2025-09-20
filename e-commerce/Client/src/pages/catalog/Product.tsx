import { AddShoppingCart } from "@mui/icons-material";
import SearchIcon from "@mui/icons-material/Search";
import type { IProduct } from "../../model/IProduct";
import {
  Card,
  CardActions,
  CardContent,
  CardMedia,
  Typography,
  Button,
} from "@mui/material";
import { Link } from "react-router";

interface Props {
  product: IProduct;
}

export default function Product({ product }: Props) {
  return (
    <Card>
      <CardMedia
        sx={{ height: 160, backgroundSize: "contain" }}
        image={`http://localhost:5280/images/${product.imageUrl}`}
      />
      <CardContent>
        <Typography
          gutterBottom
          variant="h6"
          component="h2"
          color="test.secondary"
        >
          {product.name}
        </Typography>
        <Typography variant="body2" color="text.secondary">
          {product.price.toFixed(2)} ₺
        </Typography>
      </CardContent>
      <CardActions>
        <Button variant="outlined" size="small" startIcon={<AddShoppingCart />} color="success">
          Add to Cart
        </Button>
        <Button component={Link} to={`/catalog/${product.id}`}
 variant="outlined" startIcon={<SearchIcon />} color="primary" size="small">
          View
        </Button>
      </CardActions>
    </Card>
  );
}

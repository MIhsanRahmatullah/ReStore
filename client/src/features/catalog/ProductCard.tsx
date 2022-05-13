import { Avatar, Button, Card, CardActions, CardContent, CardHeader, CardMedia, Typography } from "@mui/material";
import { fontWeight } from "@mui/system";
import { Product } from "../../app/models/Product";

interface Props {
    product: Product;
}
 
export default function ProductCard({product}: Props){
    return (
        <Card>
            <CardHeader
                avatar={
                    <Avatar sx={{bgcolor: 'secondary.main'}}>
                        {product.name.charAt(0).toUpperCase()}
                    </Avatar>
                }
                title={product.name}
                titleTypographyProps={{
                    sx: {fontWeight: 'bold' , color: 'primary.main' }
                }}
            />
        <CardMedia
          sx = {{ height: 140, backgroundSize:'contain',  }}
          image={product.pictureUrl}
          title={product.name}
        />
        <CardContent>
            <Typography gutterBottom color="secondary" variant="h5">
                RP{(product.price)}
            </Typography>
            <Typography variant="body2" color="text.secondary">
                {product.brand} /  {product.type}
            </Typography>
        </CardContent>
        <CardActions>
            <Button size="small">Add to cart</Button>
            <Button size="small">view</Button>
        </CardActions>
      </Card>
    )
}
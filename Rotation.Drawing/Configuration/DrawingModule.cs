using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autofac;
using Rotation.Drawing.ItemDrawers;
using Rotation.Drawing.ItemDrawers.Squares;
using Rotation.Drawing.Textures;

namespace Rotation.Drawing.Configuration
{
    public class DrawingModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<BlankTileTextureCreator>().As<ITileTextureCreator>();
            builder.RegisterType<StandardTileTextureCreator>().As<ITileTextureCreator>();

            builder.RegisterType<SquareDrawer>().As<IItemDrawer>();
            


        }
    }
}

using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Rowlet Specie to store common natural stats of all Rowlets
	#region SpecieRowlet
	public class SpecieRowlet : PokemonSpecie
	{
#nullable enable
		private static SpecieRowlet? _instance = null;
#nullable restore
        public static SpecieRowlet Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRowlet();
                }
                return _instance;
            }
        }

		#region SpecieRowlet Builder
		public SpecieRowlet() : base(
			"Rowlet",
			0.3,
			1.5,
			68, // HPs
			55, 55, // Attack & Defense
			50, 50, // Special Attack & Defense
			42		
		)
		{}
		#endregion
	}
	#endregion

	//Rowlet Pokemon Class
	#region Rowlet
	public class Rowlet : Pokemon
	{
		#region Rowlet Builders
		/// <summary>
		/// Rowlet Builder waiting for a Nickname & a Level
		/// </summary>
		public Rowlet(string nickname, int level)
		: base(
				722,
				SpecieRowlet.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rowlet Builder only waiting for a Level
		/// </summary>
		public Rowlet(int level)
		: base(
				722,
				SpecieRowlet.Instance, // Pokemon Specie
				"Rowlet", level,
				Grass.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rowlet Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Rowlet() : base(
			722,
			SpecieRowlet.Instance, // Pokemon Specie
			Grass.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}
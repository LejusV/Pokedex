using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Giratina-Altered PokemonInstance Class
	#region Giratina-Altered
	public class GiratinaAltered : PokemonInstance
	{
		#region Giratina-Altered Constructors
		/// <summary>
		/// Giratina-Altered Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GiratinaAltered(string nickname, int level)
		: base(
				GiratinaAlteredSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Giratina-Altered Constructor only waiting for a Level
		/// </summary>
		public GiratinaAltered(int level)
		: this( "Giratina-Altered", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Giratina-Altered Constructor waiting for no params
		/// </summary>
		/*
		public GiratinaAltered() : this( "Giratina-Altered", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}
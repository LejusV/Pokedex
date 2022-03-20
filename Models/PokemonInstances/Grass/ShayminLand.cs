using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Shaymin-Land PokemonInstance Class
	#region Shaymin-Land
	public class ShayminLand : PokemonInstance
	{
		#region Shaymin-Land Constructors
		/// <summary>
		/// Shaymin-Land Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ShayminLand(string nickname, int level)
		: base(
				ShayminLandSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shaymin-Land Constructor only waiting for a Level
		/// </summary>
		public ShayminLand(int level)
		: this( "Shaymin-Land", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shaymin-Land Constructor waiting for no params
		/// </summary>
		/*
		public ShayminLand() : this( "Shaymin-Land", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}
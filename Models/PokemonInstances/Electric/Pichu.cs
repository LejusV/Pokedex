using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Pichu PokemonInstance Class
	#region Pichu
	public class Pichu : PokemonInstance
	{
		#region Pichu Constructors
		/// <summary>
		/// Pichu Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Pichu(string nickname, int level)
		: base(
				PichuSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pichu Constructor only waiting for a Level
		/// </summary>
		public Pichu(int level)
		: this( "Pichu", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pichu Constructor waiting for no params
		/// </summary>
		/*
		public Pichu() : this( "Pichu", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}
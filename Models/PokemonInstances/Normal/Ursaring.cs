using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Ursaring PokemonInstance Class
	#region Ursaring
	public class Ursaring : PokemonInstance
	{
		#region Ursaring Constructors
		/// <summary>
		/// Ursaring Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Ursaring(string nickname, int level)
		: base(
				UrsaringSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ursaring Constructor only waiting for a Level
		/// </summary>
		public Ursaring(int level)
		: this( "Ursaring", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ursaring Constructor waiting for no params
		/// </summary>
		/*
		public Ursaring() : this( "Ursaring", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}
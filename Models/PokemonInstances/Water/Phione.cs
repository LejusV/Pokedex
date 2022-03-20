using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Phione PokemonInstance Class
	#region Phione
	public class Phione : PokemonInstance
	{
		#region Phione Constructors
		/// <summary>
		/// Phione Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Phione(string nickname, int level)
		: base(
				PhioneSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Phione Constructor only waiting for a Level
		/// </summary>
		public Phione(int level)
		: this( "Phione", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Phione Constructor waiting for no params
		/// </summary>
		/*
		public Phione() : this( "Phione", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}
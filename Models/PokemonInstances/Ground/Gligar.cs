using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Gligar PokemonInstance Class
	#region Gligar
	public class Gligar : PokemonInstance
	{
		#region Gligar Constructors
		/// <summary>
		/// Gligar Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Gligar(string nickname, int level)
		: base(
				GligarSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gligar Constructor only waiting for a Level
		/// </summary>
		public Gligar(int level)
		: this( "Gligar", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gligar Constructor waiting for no params
		/// </summary>
		/*
		public Gligar() : this( "Gligar", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}
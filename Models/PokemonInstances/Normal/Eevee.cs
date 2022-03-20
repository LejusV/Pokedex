using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Eevee PokemonInstance Class
	#region Eevee
	public class Eevee : PokemonInstance
	{
		#region Eevee Constructors
		/// <summary>
		/// Eevee Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Eevee(string nickname, int level)
		: base(
				EeveeSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Eevee Constructor only waiting for a Level
		/// </summary>
		public Eevee(int level)
		: this( "Eevee", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Eevee Constructor waiting for no params
		/// </summary>
		/*
		public Eevee() : this( "Eevee", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}
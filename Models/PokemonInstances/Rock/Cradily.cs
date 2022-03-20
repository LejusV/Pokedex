using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Cradily PokemonInstance Class
	#region Cradily
	public class Cradily : PokemonInstance
	{
		#region Cradily Constructors
		/// <summary>
		/// Cradily Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Cradily(string nickname, int level)
		: base(
				CradilySpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cradily Constructor only waiting for a Level
		/// </summary>
		public Cradily(int level)
		: this( "Cradily", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cradily Constructor waiting for no params
		/// </summary>
		/*
		public Cradily() : this( "Cradily", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}
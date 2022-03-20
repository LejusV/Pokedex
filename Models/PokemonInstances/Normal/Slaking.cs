using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Slaking PokemonInstance Class
	#region Slaking
	public class Slaking : PokemonInstance
	{
		#region Slaking Constructors
		/// <summary>
		/// Slaking Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Slaking(string nickname, int level)
		: base(
				SlakingSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Slaking Constructor only waiting for a Level
		/// </summary>
		public Slaking(int level)
		: this( "Slaking", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Slaking Constructor waiting for no params
		/// </summary>
		/*
		public Slaking() : this( "Slaking", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}
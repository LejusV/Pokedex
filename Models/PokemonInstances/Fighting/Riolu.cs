using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Riolu PokemonInstance Class
	#region Riolu
	public class Riolu : PokemonInstance
	{
		#region Riolu Constructors
		/// <summary>
		/// Riolu Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Riolu(string nickname, int level)
		: base(
				RioluSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Riolu Constructor only waiting for a Level
		/// </summary>
		public Riolu(int level)
		: this( "Riolu", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Riolu Constructor waiting for no params
		/// </summary>
		/*
		public Riolu() : this( "Riolu", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}
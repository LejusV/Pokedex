using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Blipbug PokemonInstance Class
	#region Blipbug
	public class Blipbug : PokemonInstance
	{
		#region Blipbug Constructors
		/// <summary>
		/// Blipbug Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Blipbug(string nickname, int level)
		: base(
				BlipbugSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Blipbug Constructor only waiting for a Level
		/// </summary>
		public Blipbug(int level)
		: this( "Blipbug", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Blipbug Constructor waiting for no params
		/// </summary>
		/*
		public Blipbug() : this( "Blipbug", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}
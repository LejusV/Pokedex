using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Gothorita PokemonInstance Class
	#region Gothorita
	public class Gothorita : PokemonInstance
	{
		#region Gothorita Constructors
		/// <summary>
		/// Gothorita Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Gothorita(string nickname, int level)
		: base(
				GothoritaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gothorita Constructor only waiting for a Level
		/// </summary>
		public Gothorita(int level)
		: this( "Gothorita", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gothorita Constructor waiting for no params
		/// </summary>
		/*
		public Gothorita() : this( "Gothorita", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}
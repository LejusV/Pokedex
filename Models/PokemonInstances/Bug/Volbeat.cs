using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Volbeat PokemonInstance Class
	#region Volbeat
	public class Volbeat : PokemonInstance
	{
		#region Volbeat Constructors
		/// <summary>
		/// Volbeat Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Volbeat(string nickname, int level)
		: base(
				VolbeatSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Volbeat Constructor only waiting for a Level
		/// </summary>
		public Volbeat(int level)
		: this( "Volbeat", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Volbeat Constructor waiting for no params
		/// </summary>
		/*
		public Volbeat() : this( "Volbeat", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}
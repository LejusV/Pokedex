using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Electrode PokemonInstance Class
	#region Electrode
	public class Electrode : PokemonInstance
	{
		#region Electrode Constructors
		/// <summary>
		/// Electrode Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Electrode(string nickname, int level)
		: base(
				ElectrodeSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Electrode Constructor only waiting for a Level
		/// </summary>
		public Electrode(int level)
		: this( "Electrode", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Electrode Constructor waiting for no params
		/// </summary>
		/*
		public Electrode() : this( "Electrode", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}
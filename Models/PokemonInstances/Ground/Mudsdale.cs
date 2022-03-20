using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Mudsdale PokemonInstance Class
	#region Mudsdale
	public class Mudsdale : PokemonInstance
	{
		#region Mudsdale Constructors
		/// <summary>
		/// Mudsdale Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Mudsdale(string nickname, int level)
		: base(
				MudsdaleSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mudsdale Constructor only waiting for a Level
		/// </summary>
		public Mudsdale(int level)
		: this( "Mudsdale", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mudsdale Constructor waiting for no params
		/// </summary>
		/*
		public Mudsdale() : this( "Mudsdale", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}
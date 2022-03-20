using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Toxtricity-Amped PokemonInstance Class
	#region Toxtricity-Amped
	public class ToxtricityAmped : PokemonInstance
	{
		#region Toxtricity-Amped Constructors
		/// <summary>
		/// Toxtricity-Amped Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ToxtricityAmped(string nickname, int level)
		: base(
				ToxtricityAmpedSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Toxtricity-Amped Constructor only waiting for a Level
		/// </summary>
		public ToxtricityAmped(int level)
		: this( "Toxtricity-Amped", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Toxtricity-Amped Constructor waiting for no params
		/// </summary>
		/*
		public ToxtricityAmped() : this( "Toxtricity-Amped", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}
using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Vullaby PokemonInstance Class
	#region Vullaby
	public class Vullaby : PokemonInstance
	{
		#region Vullaby Constructors
		/// <summary>
		/// Vullaby Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Vullaby(string nickname, int level)
		: base(
				VullabySpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vullaby Constructor only waiting for a Level
		/// </summary>
		public Vullaby(int level)
		: this( "Vullaby", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vullaby Constructor waiting for no params
		/// </summary>
		/*
		public Vullaby() : this( "Vullaby", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}
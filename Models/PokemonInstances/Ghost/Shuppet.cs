using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Shuppet PokemonInstance Class
	#region Shuppet
	public class Shuppet : PokemonInstance
	{
		#region Shuppet Constructors
		/// <summary>
		/// Shuppet Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Shuppet(string nickname, int level)
		: base(
				ShuppetSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shuppet Constructor only waiting for a Level
		/// </summary>
		public Shuppet(int level)
		: this( "Shuppet", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shuppet Constructor waiting for no params
		/// </summary>
		/*
		public Shuppet() : this( "Shuppet", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}
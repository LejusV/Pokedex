using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Wobbuffet PokemonInstance Class
	#region Wobbuffet
	public class Wobbuffet : PokemonInstance
	{
		#region Wobbuffet Constructors
		/// <summary>
		/// Wobbuffet Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Wobbuffet(string nickname, int level)
		: base(
				WobbuffetSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wobbuffet Constructor only waiting for a Level
		/// </summary>
		public Wobbuffet(int level)
		: this( "Wobbuffet", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wobbuffet Constructor waiting for no params
		/// </summary>
		/*
		public Wobbuffet() : this( "Wobbuffet", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}
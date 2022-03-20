using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Charjabug PokemonInstance Class
	#region Charjabug
	public class Charjabug : PokemonInstance
	{
		#region Charjabug Constructors
		/// <summary>
		/// Charjabug Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Charjabug(string nickname, int level)
		: base(
				CharjabugSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Charjabug Constructor only waiting for a Level
		/// </summary>
		public Charjabug(int level)
		: this( "Charjabug", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Charjabug Constructor waiting for no params
		/// </summary>
		/*
		public Charjabug() : this( "Charjabug", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}
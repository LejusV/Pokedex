using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Mantine PokemonInstance Class
	#region Mantine
	public class Mantine : PokemonInstance
	{
		#region Mantine Constructors
		/// <summary>
		/// Mantine Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Mantine(string nickname, int level)
		: base(
				MantineSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mantine Constructor only waiting for a Level
		/// </summary>
		public Mantine(int level)
		: this( "Mantine", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mantine Constructor waiting for no params
		/// </summary>
		/*
		public Mantine() : this( "Mantine", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}
using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Sylveon PokemonInstance Class
	#region Sylveon
	public class Sylveon : PokemonInstance
	{
		#region Sylveon Constructors
		/// <summary>
		/// Sylveon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Sylveon(string nickname, int level)
		: base(
				SylveonSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sylveon Constructor only waiting for a Level
		/// </summary>
		public Sylveon(int level)
		: this( "Sylveon", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sylveon Constructor waiting for no params
		/// </summary>
		/*
		public Sylveon() : this( "Sylveon", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}
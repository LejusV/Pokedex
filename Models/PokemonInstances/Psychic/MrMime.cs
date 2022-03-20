using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Mr-Mime PokemonInstance Class
	#region Mr-Mime
	public class MrMime : PokemonInstance
	{
		#region Mr-Mime Constructors
		/// <summary>
		/// Mr-Mime Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MrMime(string nickname, int level)
		: base(
				MrMimeSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mr-Mime Constructor only waiting for a Level
		/// </summary>
		public MrMime(int level)
		: this( "Mr-Mime", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mr-Mime Constructor waiting for no params
		/// </summary>
		/*
		public MrMime() : this( "Mr-Mime", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}
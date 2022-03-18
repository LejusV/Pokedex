using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Vullaby Species to store common natural stats of all Vullabys
	#region SpeciesVullaby
	public class SpeciesVullaby : PokemonSpecies
	{
#nullable enable
		private static SpeciesVullaby? _instance = null;
#nullable restore
        public static SpeciesVullaby Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesVullaby();
                }
                return _instance;
            }
        }

		#region SpeciesVullaby Constructor
		public SpeciesVullaby() : base(
			629,
			"Vullaby",
			0.5,
			9.0,
			70, // HPs
			55, 75, // Attack & Defense
			45, 65, // Special Attack & Defense
			60		
		)
		{
			InitMovesList();
		}
		#endregion

		#region Methods
		private void InitMovesList()
		{
			_moveList = new List<string>()
			{
				"Cut",
				"Gust",
				"Whirlwind",
				"Fly",
				"Fury-Attack",
				"Leer",
				"Toxic",
				"Double-Team",
				"Mirror-Move",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Scary-Face",
				"Feint-Attack",
				"Swagger",
				"Steel-Wing",
				"Mean-Look",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Heat-Wave",
				"Torment",
				"Flatter",
				"Facade",
				"Taunt",
				"Knock-Off",
				"Snatch",
				"Secret-Power",
				"Fake-Tears",
				"Rock-Tomb",
				"Aerial-Ace",
				"Iron-Defense",
				"Block",
				"Roost",
				"Pluck",
				"Tailwind",
				"U-Turn",
				"Payback",
				"Embargo",
				"Punishment",
				"Dark-Pulse",
				"Air-Slash",
				"Brave-Bird",
				"Nasty-Plot",
				"Defog",
				"Foul-Play",
				"Round",
				"Incinerate",
				"Retaliate",
				"Snarl",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Vullaby PokemonInstance Class
	#region Vullaby
	public class VullabyInstance : PokemonInstance
	{
		#region Vullaby Constructors
		/// <summary>
		/// Vullaby Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public VullabyInstance(string nickname, int level)
		: base(
				SpeciesVullaby.Instance, // Pokemon Species
				nickname, level,
				Dark.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vullaby Builder only waiting for a Level
		/// </summary>
		public VullabyInstance(int level)
		: base(
				SpeciesVullaby.Instance, // PokemonInstance Species
				"Vullaby", level,
				Dark.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vullaby Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public VullabyInstance() : base(
			SpeciesVullaby.Instance, // PokemonInstance Species
			Dark.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}
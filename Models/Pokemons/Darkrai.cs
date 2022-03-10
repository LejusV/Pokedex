using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Darkrai Species to store common natural stats of all Darkrais
	#region SpeciesDarkrai
	public class SpeciesDarkrai : PokemonSpecies
	{
#nullable enable
		private static SpeciesDarkrai? _instance = null;
#nullable restore
        public static SpeciesDarkrai Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDarkrai();
                }
                return _instance;
            }
        }

		#region SpeciesDarkrai Constructor
		public SpeciesDarkrai() : base(
			"Darkrai",
			1.5,
			50.5,
			70, // HPs
			90, 90, // Attack & Defense
			135, 90, // Special Attack & Defense
			125		
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
				"Swords-Dance",
				"Cut",
				"Headbutt",
				"Disable",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Strength",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Psychic",
				"Hypnosis",
				"Quick-Attack",
				"Night-Shade",
				"Double-Team",
				"Haze",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Spite",
				"Protect",
				"Feint-Attack",
				"Sludge-Bomb",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Torment",
				"Will-O-Wisp",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Trick",
				"Brick-Break",
				"Knock-Off",
				"Snatch",
				"Secret-Power",
				"Rock-Tomb",
				"Aerial-Ace",
				"Calm-Mind",
				"Shock-Wave",
				"Natural-Gift",
				"Payback",
				"Embargo",
				"Fling",
				"Last-Resort",
				"Sucker-Punch",
				"Poison-Jab",
				"Dark-Pulse",
				"X-Scissor",
				"Drain-Punch",
				"Focus-Blast",
				"Giga-Impact",
				"Nasty-Plot",
				"Shadow-Claw",
				"Rock-Climb",
				"Charge-Beam",
				"Dark-Void",
				"Ominous-Wind",
				"Wonder-Room",
				"Foul-Play",
				"Round",
				"Incinerate",
				"Retaliate",
				"Snarl",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Darkrai PokemonInstance Class
	#region Darkrai
	public class DarkraiInstance : PokemonInstance
	{
		#region Darkrai Constructors
		/// <summary>
		/// Darkrai Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DarkraiInstance(string nickname, int level)
		: base(
				491,
				SpeciesDarkrai.Instance, // Pokemon Species
				nickname, level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Darkrai Builder only waiting for a Level
		/// </summary>
		public DarkraiInstance(int level)
		: base(
				491,
				SpeciesDarkrai.Instance, // PokemonInstance Species
				"Darkrai", level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Darkrai Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Darkrai() : base(
			491,
			SpeciesDarkrai.Instance, // PokemonInstance Species
			Dark.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}
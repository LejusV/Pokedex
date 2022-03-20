using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Darkrai Species to store common natural stats of all Darkrais
	#region DarkraiSpecies
	public class DarkraiSpecies : PokemonSpecies
	{
#nullable enable
		private static DarkraiSpecies? _instance = null;
#nullable restore
        public static DarkraiSpecies Instance => _instance ?? (_instance = new DarkraiSpecies());

		#region DarkraiSpecies Constructor
		public DarkraiSpecies() : base(
			491,
			"Darkrai",
			Dark.Instance,
			1.5,
			50.5,
			new PokemonStats(
				70, // HPs
				90, 90, // Attack & Defense
				135, 90, // Spacial Attack & Defense
				125 // Speed
			)			
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
}
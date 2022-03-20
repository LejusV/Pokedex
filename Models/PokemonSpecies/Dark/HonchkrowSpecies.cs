using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Honchkrow Species to store common natural stats of all Honchkrows
	#region HonchkrowSpecies
	public class HonchkrowSpecies : PokemonSpecies
	{
#nullable enable
		private static HonchkrowSpecies? _instance = null;
#nullable restore
        public static HonchkrowSpecies Instance => _instance ?? (_instance = new HonchkrowSpecies());

		#region HonchkrowSpecies Constructor
		public HonchkrowSpecies() : base(
			430,
			"Honchkrow",
			Dark.Instance, Flying.Instance,
			0.9,
			27.3,
			new PokemonStats(
				100, // HPs
				125, 52, // Attack & Defense
				105, 52, // Spacial Attack & Defense
				71 // Speed
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
				"Wing-Attack",
				"Fly",
				"Hyper-Beam",
				"Thunder-Wave",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Haze",
				"Swift",
				"Dream-Eater",
				"Sky-Attack",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Uproar",
				"Heat-Wave",
				"Torment",
				"Facade",
				"Taunt",
				"Superpower",
				"Snatch",
				"Secret-Power",
				"Astonish",
				"Air-Cutter",
				"Aerial-Ace",
				"Calm-Mind",
				"Roost",
				"Natural-Gift",
				"Pluck",
				"Tailwind",
				"Payback",
				"Embargo",
				"Sucker-Punch",
				"Dark-Pulse",
				"Night-Slash",
				"Giga-Impact",
				"Nasty-Plot",
				"Defog",
				"Captivate",
				"Ominous-Wind",
				"Foul-Play",
				"Round",
				"Incinerate",
				"Quash",
				"Retaliate",
				"Snarl",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}
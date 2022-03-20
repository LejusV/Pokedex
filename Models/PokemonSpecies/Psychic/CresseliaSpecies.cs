using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Cresselia Species to store common natural stats of all Cresselias
	#region CresseliaSpecies
	public class CresseliaSpecies : PokemonSpecies
	{
#nullable enable
		private static CresseliaSpecies? _instance = null;
#nullable restore
        public static CresseliaSpecies Instance => _instance ?? (_instance = new CresseliaSpecies());

		#region CresseliaSpecies Constructor
		public CresseliaSpecies() : base(
			488,
			"Cresselia",
			Psychic.Instance,
			1.5,
			85.6,
			new PokemonStats(
				120, // HPs
				70, 120, // Attack & Defense
				75, 130, // Spacial Attack & Defense
				85 // Speed
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
				"Mist",
				"Ice-Beam",
				"Aurora-Beam",
				"Hyper-Beam",
				"Solar-Beam",
				"Thunder-Wave",
				"Toxic",
				"Confusion",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Slash",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Moonlight",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Future-Sight",
				"Facade",
				"Helping-Hand",
				"Trick",
				"Magic-Coat",
				"Recycle",
				"Skill-Swap",
				"Secret-Power",
				"Signal-Beam",
				"Calm-Mind",
				"Gravity",
				"Natural-Gift",
				"Psycho-Shift",
				"Energy-Ball",
				"Giga-Impact",
				"Psycho-Cut",
				"Zen-Headbutt",
				"Trick-Room",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Lunar-Dance",
				"Psyshock",
				"Telekinesis",
				"Magic-Room",
				"Round",
				"Moonblast",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}
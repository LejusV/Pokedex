using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Porygon Species to store common natural stats of all Porygons
	#region PorygonSpecies
	public class PorygonSpecies : PokemonSpecies
	{
#nullable enable
		private static PorygonSpecies? _instance = null;
#nullable restore
        public static PorygonSpecies Instance => _instance ?? (_instance = new PorygonSpecies());

		#region PorygonSpecies Constructor
		public PorygonSpecies() : base(
			137,
			"Porygon",
			Normal.Instance,
			0.8,
			36.5,
			new PokemonStats(
				65, // HPs
				60, 70, // Attack & Defense
				85, 75, // Spacial Attack & Defense
				40 // Speed
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
				"Tackle",
				"Take-Down",
				"Double-Edge",
				"Ice-Beam",
				"Blizzard",
				"Psybeam",
				"Hyper-Beam",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Psychic",
				"Agility",
				"Rage",
				"Teleport",
				"Mimic",
				"Double-Team",
				"Recover",
				"Reflect",
				"Bide",
				"Swift",
				"Skull-Bash",
				"Dream-Eater",
				"Flash",
				"Psywave",
				"Rest",
				"Sharpen",
				"Conversion",
				"Tri-Attack",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Curse",
				"Conversion-2",
				"Protect",
				"Zap-Cannon",
				"Icy-Wind",
				"Lock-On",
				"Endure",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Facade",
				"Trick",
				"Magic-Coat",
				"Recycle",
				"Secret-Power",
				"Signal-Beam",
				"Aerial-Ace",
				"Shock-Wave",
				"Gravity",
				"Natural-Gift",
				"Last-Resort",
				"Magnet-Rise",
				"Giga-Impact",
				"Zen-Headbutt",
				"Trick-Room",
				"Discharge",
				"Charge-Beam",
				"Wonder-Room",
				"Psyshock",
				"Foul-Play",
				"Round",
				"Electroweb",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}
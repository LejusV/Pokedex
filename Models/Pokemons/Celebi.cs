using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Celebi Specie to store common natural stats of every {'abilities': ['natural-cure'], 'base_experience': 270, 'height': 6, 'id': 251, 'moves': ['swords-dance', 'cut', 'double-edge', 'hyper-beam', 'leech-seed', 'solar-beam', 'thunder-wave', 'toxic', 'confusion', 'psychic', 'mimic', 'double-team', 'recover', 'defense-curl', 'light-screen', 'reflect', 'metronome', 'swift', 'dream-eater', 'flash', 'rest', 'substitute', 'nightmare', 'snore', 'curse', 'protect', 'mud-slap', 'perish-song', 'detect', 'sandstorm', 'giga-drain', 'endure', 'swagger', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'safeguard', 'baton-pass', 'sweet-scent', 'synthesis', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'ancient-power', 'shadow-ball', 'future-sight', 'uproar', 'facade', 'nature-power', 'helping-hand', 'trick', 'magic-coat', 'skill-swap', 'secret-power', 'silver-wind', 'signal-beam', 'aerial-ace', 'magical-leaf', 'calm-mind', 'shock-wave', 'water-pulse', 'healing-wish', 'natural-gift', 'u-turn', 'fling', 'heal-block', 'last-resort', 'worry-seed', 'sucker-punch', 'seed-bomb', 'energy-ball', 'earth-power', 'giga-impact', 'zen-headbutt', 'trick-room', 'leaf-storm', 'stealth-rock', 'grass-knot', 'charge-beam', 'wonder-room', 'magic-room', 'round', 'echoed-voice', 'confide', 'dazzling-gleam'], 'name': 'celebi', 'stats': {'hp': 100, 'attack': 100, 'defense': 100, 'special-attack': 100, 'special-defense': 100, 'speed': 100}, 'types': ['psychic', 'grass'], 'weight': 50, 'is_baby': False, 'is_legendary': False, 'is_mythical': True, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 45, 'color': 'green', 'shape': 'humanoid', 'habitat': 'forest', 'generation': 'generation-ii', 'growth_rate': 'medium-slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'セレビィ', 'roomaji': 'Celebi', 'ko': '세레비', 'zh-Hant': '時拉比', 'fr': 'Celebi', 'de': 'Celebi', 'es': 'Celebi', 'it': 'Celebi', 'en': 'Celebi', 'ja': 'セレビィ', 'zh-Hans': '时拉比'}, 'genera': {'ja-Hrkt': 'ときわたりポケモン', 'ko': '시간이동포켓몬', 'zh-Hant': '時空穿越寶可夢', 'fr': 'Pokémon Temporel', 'de': 'Zeitreise', 'es': 'Pokémon Viajetiempo', 'it': 'Pokémon Tempovia', 'en': 'Time Travel Pokémon', 'ja': 'ときわたりポケモン', 'zh-Hans': '时空穿越宝可梦'}}
	public class SpecieCelebi : PokemonSpecie
	{
#nullable enable
		private static SpecieCelebi? _instance = null;
#nullable restore
        public static SpecieCelebi Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCelebi();
                }
                return _instance;
            }
        }

		public SpecieCelebi() : base(
			"Celebi",
			100, // HPs
			100, 100, // Attack & Defense
			100, 100, // Special Attack & Defense
			100			
		) {}
	}


	//Celebi Pokemon Class
	public class Celebi : Pokemon
	{

		public Celebi(string nickname, int level)
		: base(
				251,
				SpecieCelebi.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Celebi() : base(
			251,
			SpecieCelebi.Instance, // Pokemon Specie
			Psychic.Instance, Grass.Instance			
		) {}
	}
}
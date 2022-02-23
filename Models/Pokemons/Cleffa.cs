using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Cleffa Specie to store common natural stats of every {'abilities': ['cute-charm', 'magic-guard', 'friend-guard'], 'base_experience': 44, 'height': 3, 'id': 173, 'moves': ['pound', 'mega-punch', 'mega-kick', 'headbutt', 'body-slam', 'double-edge', 'sing', 'flamethrower', 'counter', 'seismic-toss', 'solar-beam', 'thunder-wave', 'dig', 'toxic', 'psychic', 'mimic', 'double-team', 'defense-curl', 'light-screen', 'reflect', 'metronome', 'fire-blast', 'amnesia', 'soft-boiled', 'dream-eater', 'flash', 'splash', 'rest', 'substitute', 'nightmare', 'snore', 'curse', 'protect', 'sweet-kiss', 'belly-drum', 'mud-slap', 'zap-cannon', 'icy-wind', 'detect', 'endure', 'charm', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'present', 'frustration', 'safeguard', 'encore', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'uproar', 'facade', 'helping-hand', 'trick', 'role-play', 'wish', 'magic-coat', 'recycle', 'endeavor', 'secret-power', 'hyper-voice', 'aromatherapy', 'fake-tears', 'tickle', 'signal-beam', 'covet', 'magical-leaf', 'shock-wave', 'water-pulse', 'gravity', 'natural-gift', 'fling', 'copycat', 'last-resort', 'zen-headbutt', 'captivate', 'grass-knot', 'wonder-room', 'psyshock', 'telekinesis', 'after-you', 'round', 'echoed-voice', 'stored-power', 'heal-pulse', 'incinerate', 'work-up', 'misty-terrain', 'confide'], 'name': 'cleffa', 'stats': {'hp': 50, 'attack': 25, 'defense': 28, 'special-attack': 45, 'special-defense': 55, 'speed': 15}, 'types': ['fairy'], 'weight': 30, 'is_baby': True, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 10, 'gender_rate': 6, 'capture_rate': 150, 'color': 'pink', 'shape': 'upright', 'habitat': 'mountain', 'generation': 'generation-ii', 'growth_rate': 'fast', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'ピィ', 'roomaji': 'Py', 'ko': '삐', 'zh-Hant': '皮寶寶', 'fr': 'Mélo', 'de': 'Pii', 'es': 'Cleffa', 'it': 'Cleffa', 'en': 'Cleffa', 'ja': 'ピィ', 'zh-Hans': '皮宝宝'}, 'genera': {'ja-Hrkt': 'ほしがたポケモン', 'ko': '별포켓몬', 'zh-Hant': '星形寶可夢', 'fr': 'Pokémon Étoile', 'de': 'Sternform', 'es': 'Pokémon Estrellada', 'it': 'Pokémon Stella', 'en': 'Star Shape Pokémon', 'ja': 'ほしがたポケモン', 'zh-Hans': '星形宝可梦'}}
	public class SpecieCleffa : PokemonSpecie
	{
#nullable enable
		private static SpecieCleffa? _instance = null;
#nullable restore
        public static SpecieCleffa Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCleffa();
                }
                return _instance;
            }
        }

		public SpecieCleffa() : base(
			"Cleffa",
			50, // HPs
			25, 28, // Attack & Defense
			45, 55, // Special Attack & Defense
			15			
		) {}
	}


	//Cleffa Pokemon Class
	public class Cleffa : Pokemon
	{

		public Cleffa(string nickname, int level) : base(
			173,
			SpecieCleffa.Instance, // Pokemon Specie
			nickname, level,
			Fairy.Instance			
		) {}

		public Cleffa() : base(
			173,
			SpecieCleffa.Instance, // Pokemon Specie
			Fairy.Instance			
		) {}
	}
}